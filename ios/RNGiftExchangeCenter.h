#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNGiftExchangeCenter : UIResponder

+ (instancetype)shared;
- (void)giftExchangeCenter_ex_configJanServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
